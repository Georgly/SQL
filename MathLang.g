grammar MathLang;

options {
  language=CSharp3;
  output=AST;

  backtrack=true;
  memoize=true;
}


tokens {
  SELECT = 'select'    ;
  FROM = 'from'        ;
  WHERE = 'where'      ;
  GROUP_BY = 'group by' ;
  ORDER_BY = 'order by' ;
  HAVING = 'having'    ;
  PROGRAM              ;
  BLOCK                ;
  FIELDS               ;
  TABLES               ;
}


@lexer::namespace { MathLang }
@parser::namespace { MathLang }


WS:
  ( ' ' | '\t' |  '\f' | '\r' | '\n' )+ {
    $channel=Hidden;
  }
;

SL_COMMENT:
  '//' (options { greedy=false; }: .)* '\r'? '\n' {
    $channel=Hidden;
  }
;
ML_COMMENT:
  '/*' (options { greedy=false; }: .)* '*/' {
    $channel=Hidden;
  }
;



NUMBER: ('0'..'9')+ ('.' ('0'..'9')+)?
;
FIELD: ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )
        ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )*  
;

DOT:    '.'     ;

ADD:    '+'     ;
SUB:    '-'     ;
MUL:    '*'     ;
DIV:    '/'     ;

GE:       '>='  ;
LE:       '<='  ;
NEQUALS:  '<>'  ;
EQUALS:   '=='  ;
GT:       '>'   ;
LT:       '<'   ;

ASSIGN: '='     ;



group:
  '('! term ')'!
| NUMBER
| request_params
| '('! expr1 ')'!
;

mult: group ( ( MUL | DIV )^ group )*  ;
add:  mult  ( ( ADD | SUB )^ mult  )*  ;
compare: add ( ( GE | LE | NEQUALS | EQUALS | GT | LT)^ add )?  ;
term: compare  ;

table_field: (FIELD DOT^ (FIELD | '*')) | FIELD;
request_params : '*' | table_field;
formal_params: ( request_params (',' request_params)* ) -> ^(FIELDS request_params+);
select_: SELECT^ formal_params;

tables_or_request: FIELD | '('! expr1 ')'!;
request_tables: (tables_or_request (',' tables_or_request)*) -> ^(TABLES tables_or_request+);
from_: FROM^ request_tables;

fields_list: table_field (','! table_field)*;
groupby: GROUP_BY^ fields_list;

orderby: ORDER_BY^ fields_list;

where_: WHERE^ term;
having_: HAVING^ term
;

expr1:
  select_
  from_
  expr2
;

expr2:
  where_?
  groupby?
  having_?
  orderby?
;

exprList:
  ( expr1 (';')!)+ -> ^(BLOCK expr1)
;

program: exprList  ;

result: program EOF!;

public execute:
  result
;