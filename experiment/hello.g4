grammar hello;

options { language=CSharp; }

r: 'hello' ID ;

ID: [a-z]+ ;

WS: [ \t\r\n]+ -> skip ;