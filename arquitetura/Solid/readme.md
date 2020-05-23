# Solid Principles

## SRP - Single Responsability Principle

Cada classe deve ter uma responsabilidade unica.

Ele diz que cada classe deve ter a responsabilidade individual. Uma classe não deve ter mais do que uma razão para a mudança.


## OCP - Open Closed Principle

A capacidade de estender o comportamento de uma classe sem modifica-la.

A classe deve ser aberta para uma extensão e fechado para a modificação.

Situação: Você tem uma classe Customer com propriedade InvoiceNumber do tipo int. Após algum tempo, houve uma mudança na empresa, e agora ela
passa a aceitar um valor alfanumérico. 

A solução seria criar uma subclasse nova de `CustomerNew` com o tipo `new`string` na propriedade.


## LSP - Liskov Substitution Principle

Um objeto pai deve ser capaz de substituir o seu filho durante o polimorfismo em tempo de execução.

Classes derivadas, podem substituir classes base. O princípio LISKOV diz que o pai deve facilmente substituir o objeto filho.

Situação: 


## ISP - Interface Segregation Principle 

Interfaces especificas, são melhores do que uma interface geral.

Situação: Você tem uma interface chamada `IClick` com 2 metodos, `onClick()` e `onLongClick()`. 
Após algum tempo surgiu uma demanda que precisa adicionar a função0 `onTouch()`.

Solução: 
Como o mome da interface `IClick` não faz sentido ter o `onTouch()`, a solução do `ISP` seria ter duas interfaces. Uma para `IClick` e outra para `ITouch`.


## DIP - Dependence Inversion Principle

Um modulo de nível superior, JAMAIS deve depender de um modulo de nível inferior.

Situação:

Temos a classe `Customer`, que grava um novo cliente. Nela existe um metodo que grava um log de sucesso/erro.

