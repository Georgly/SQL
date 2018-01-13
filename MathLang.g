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
  ORDER_BY = 'order by' ;
  PROGRAM              ;
  BLOCK                ;
  FIELDS               ;
  TABLES               ;
  REQUEST              ;
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

STRING: '"' FIELD* '"'
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
| STRING
| request_params
| '('! exprList ')'!
;

mult: group ( ( MUL | DIV )^ group )*  ;
add:  mult  ( ( ADD | SUB )^ mult  )*  ;
compare: add ( ( GE | LE | NEQUALS | EQUALS | GT | LT)^ add )?  ;
term: compare  ;

table_field: (FIELD DOT^ (FIELD | '*')) | FIELD;
request_params : '*' | table_field;
formal_params: ( request_params (',' request_params)* ) -> ^(FIELDS request_params+);
select_: SELECT^ formal_params;

tables_or_request: FIELD | '('! exprList ')'!;
request_tables: (tables_or_request (',' tables_or_request)*) -> ^(TABLES tables_or_request+);
from_: FROM^ request_tables;

fields_list: table_field (','! table_field)*;
orderby: ORDER_BY^ fields_list;

where_: WHERE^ term
;

expr1:
  select_
  from_
  expr2
;

expr2:
  where_?
  orderby?
;

exprList:
   ( expr1 ) -> ^(BLOCK expr1)
;

requestList:
 (exprList (';')!) -> ^(REQUEST exprList)
;

program: requestList  ;

result: program EOF!;

public execute:
  result
;