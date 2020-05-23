# Solid Principles

## SRP - Single Responsability Principle

Cada classe deve ter uma responsabilidade unica.

Ele diz que cada classe deve ter a responsabilidade individual. Uma classe n�o deve ter mais do que uma raz�o para a mudan�a.


## OCP - Open Closed Principle

A capacidade de estender o comportamento de uma classe sem modifica-la.

A classe deve ser aberta para uma extens�o e fechado para a modifica��o.

Situa��o: Voc� tem uma classe Customer com propriedade InvoiceNumber do tipo int. Ap�s algum tempo, houve uma mudan�a na empresa, e agora ela
passa a aceitar um valor alfanum�rico. 

A solu��o seria criar uma subclasse nova de `CustomerNew` com o tipo `new`string` na propriedade.


## LSP - Liskov Substitution Principle

Um objeto pai deve ser capaz de substituir o seu filho durante o polimorfismo em tempo de execu��o.

Classes derivadas, podem substituir classes base. O princ�pio LISKOV diz que o pai deve facilmente substituir o objeto filho.

Situa��o: 


## ISP - Interface Segregation Principle 

Interfaces especificas, s�o melhores do que uma interface geral.

Situa��o: Voc� tem uma interface chamada `IClick` com 2 metodos, `onClick()` e `onLongClick()`. 
Ap�s algum tempo surgiu uma demanda que precisa adicionar a fun��o0 `onTouch()`.

Solu��o: 
Como o mome da interface `IClick` n�o faz sentido ter o `onTouch()`, a solu��o do `ISP` seria ter duas interfaces. Uma para `IClick` e outra para `ITouch`.


## DIP - Dependence Inversion Principle

Um modulo de n�vel superior, JAMAIS deve depender de um modulo de n�vel inferior.

Situa��o:

Temos a classe `Customer`, que grava um novo cliente. Nela existe um metodo que grava um log de sucesso/erro.

