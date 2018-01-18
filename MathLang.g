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
  AS = 'as'            ;
  PROGRAM              ;
  BLOCK                ;
  FIELDS               ;
  TABLES               ;
  REQUEST              ;
  SORT                 ;
  AND = 'and'          ;
  OR = 'or'            ;
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

TEXT: '"' FIELD* '"'
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
| TEXT
| table_field
| ('('! exprList ')'! (AS^ FIELD)?)
;

mult: group ( ( MUL | DIV )^ group )*  ;
add:  mult  ( ( ADD | SUB )^ mult  )*  ;
compare: add ( ( GE | LE | NEQUALS | EQUALS | GT | LT)^ add )?  ;
and: compare (AND^ compare )* ;
or: and (OR^ and )*;
term: or;

table_field: (FIELD DOT^ (FIELD | '*')) | FIELD;
request_params : '*' | table_field;
formal_params: ( request_params (',' request_params)* ) -> ^(FIELDS request_params+);
select_: SELECT^ formal_params;

tables_or_request: FIELD | ('('! exprList ')'! AS^ FIELD);
request_tables: (tables_or_request (',' tables_or_request)*) -> ^(TABLES tables_or_request+);
from_: FROM^ request_tables;

orderby : (NUMBER (',' NUMBER)*) -> ^(SORT NUMBER+);
orderby_: ORDER_BY^ orderby;

where_: WHERE^ term
;

expr1:
  select_
  from_
  expr2
;

expr2:
  where_?
  orderby_?
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