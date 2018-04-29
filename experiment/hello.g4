grammar hello;

hellofile: r+ ;

r: 'hello' ID ;

ID: [a-z]+ ;

WS: [ \t\r\n]+ -> skip ; 