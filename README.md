# Design Patterns

Design Patterns são padrões, formas de resolver problemas comuns da programação, independente de linguagem, mas em alguns casos mais focados no paradigma de OOP. Um dos seus grandes benefícios é ter uma forma comum e pronta de resolver um problema específico, isso facilita muito a comunicação e ambientação de outras pessoas na equipe.

<img src="https://springframework.guru/wp-content/uploads/2015/04/9780201633610.jpg" width="150px"></img>

Quando se fala de Design Patterns não podemos deixar de falar sobre o GOF(Gang Of Four), basicamente foram os responsáveis por organizar em um livro os principais desogn patterns usados na época(e ainda são muito usados), certamente vocÊe já viu esse livro circulando por ai, nele você vai encontrar 23 padrões de projetos, mas, na prática existem muitos outros que não estão lá.

## Classificação

Podemos dividir os Design Patterns em três conjuntos: Criacionais, Estruturais e Comportamentais.

<img src="https://res.cloudinary.com/practicaldev/image/fetch/s--kCLRYrmn--/c_limit%2Cf_auto%2Cfl_progressive%2Cq_auto%2Cw_880/https://www.lambdatest.com/blog/wp-content/uploads/2021/03/Behavioral-Design-Patterns.png" width="450px"></img>

## Criacionais

A grande ideia aqui é abstrair e facilitar o processo de criação de objetos, a criação de uma nova instância, abstraindo e facilitando o processo de instanciar objetos complexos. E o mais legal é que essa categoria de padrões pode trabalhar com configuração statica(hard coded), ou configurações dinâmicas, buscando dados para se configurar em um banco, um arquivo...

Importante, cada vez menos você vai ver essa categoria, pois em sua grande parte está sendo subsititúida por containers de injeção de dependência.

[Exemplos de código 🗂️](./1-Criasionais/)

### Singleton

Vamos iniciar com um dos mais controversos, ele pode nos dar muitas dores de cabeça para situações onde nosso código roda em mais de uma thread, e também em casos de testes de unidade, pois acaba sendo muito difícil de colocar um duble de teste em seu lugar.

Na prática, a sua ideia é garantir que exista apenas uma instância do objeto em toda sua aplicação. É muito prático em situações onde todos os usuários de uma classe precisam usar das mesmas informações.

### Factory Method

Esse é um padrão muito usado para a abstrair o processo de instanciar um conjunto de classes que implementam o mesmo contrato. Ná pratica, você tem uma fábrica que recebe parâmetros e sempre retorna uma instância de uma class que implementa o contrato.

Vamos para o nosso exemplo, onde dependendo da regra que o usuário possúi, as taxas que ele vai pagar pode mudar. A gente tem a opção em tudo que é lugar pegar a config desse usuário e instanciar a classe com as suas regras, ou a gente pode centralizar isso em uma fábrica que retorna classes que sabem fazer esse cálculo conforme com a regra passada.

<img src="./images/factory-method.png" width="600px"/>

### Abstract Factory

Já entendemos o que é uma fábrica quando falamos do Factory Method, e o Abstract Factory também não está foge muito da disso, a ideia é ser uma fábrica não apenas de um tipo de classe, mas sim de um conjunto; Em muitos lugares você pode ler algo falando que é uma fábrica de fábricas, isso não está 100% errado, mas, na prática, ela não se restringe conceitualmente somente a isso.

Vamos para o nosso exemplo de um sistema de relatórios de compras feitas, que hoje temos dois tipos, a geração dos relatórios HTML e em CSV, são os mesmos dados de entrada, mas o que muda é como eles são apresentados, e importante, temos apenas duas regras que se aplicam independente do tipo do arquivo, quando não informações na lista de compras, o relatório vai ter informações diferentes; Na prática, teremos um factory para o tipo CSV, um factory para o tipo HTML, e um factory que vai fazer o uso dos dois anteriores, que vai ser o nosso abstract factory, da uma olhada no desenho.

<img src="./images/abstract-factory.png" width="600px"/>

### Builder

Esse é um dos mais legais quando se fala de criacionais. Seu papel é facilitar a criação de objetos complexos de forma dinâmica, sem obrigatoriamente passar tudo de uma vez só no construtor.

Um exemplo bem legal que a gente continuar no exemplo de relatório, é um gerador de relatório HTML de forma dinâmica usando código, onde dependendo dos dados, você monta de uma forma ou de outra.

Pensando no nosso exemplo, teríamos uma classe de reportBuilder, que você vai chamando os métodos, como o de Adiciar o header, Adicionar summary, adiciona transaçoes, adicionar quebra de linha... e depois de tudo configurado você vai chamar o método de build, que vai pegar tudo que você colocou em ordem, validar, e se estiver tudo correto vai retornar o nosso report!

<img src="./images/builder.png" width="600px"/>

### Prototype

Esse é um dos mais simples, seu papel é fazer o clone de um objeto de uma forma fácil, isso tudo emcapsulado dentro do próprio objeto, como um método de Clone, isso nos ajuda a não sair espalhando essa logica de como clonar o objeto de um lado para o outro.

Um caso bem legal de prototype é a linguagem JavaScript, para forcener herança, ela faz p uso desse conceito, onde vai se fazendo um clone do objeto e adicionando novos conceitos nesse clone

<img src="https://banisd.files.wordpress.com/2014/01/protochain1-e1389963022801.png?w=584" width="400px"/>

---

## Estruturais

[Exemplos de código 🗂️](./2-Estruturais/)


### Flyweight

Também conhecido como cache, ele tem como principal objetivo diminuir o uso de memória RAM, compartilhando pontos em comum entre várias instâncias de objetos. Contudo, em vários momentos você vai estar trocando menor uso de memória por complexidade e maior uso de CPU e/ou GPU, coloque sempre na balança antes de decidir. Um grande ponto a se levar em consideração é se você vai ter um grande número de objetos repetidos!

<img src="https://reactiveprogramming.io/books/patterns/img/patterns/flyweight2.png" width="600px"/>


## Comportamentais

[Exemplos de código 🗂️](./3-Comportamentais/)

### Strategy

Padrão comportamental que tem como foco a facilitar a implementação de problemas onde você tem várias estratégias para resolver o mesmo problema. O exemplo clássico é o dos impostos, onde você tem uma calculadora de impostos, e vários impostos diferentes(estrategias diferentes)

<img src="https://oowisdom.csse.canterbury.ac.nz/images/4/43/StrategyExampleTax.gif" width="700px"/>

### Mediator

Ele serve basicamente como um orquestrador de commands/queries, ele faz com que quem envia o "evento" não precise conhecer quem processa, ele precisa conhecer apenas o _mediator_. Bom, na prática a gente pode até pensar que isso diminui o acoplamento, e sim, diminui o acoplamento estético, mas o acoplamento dinâmico continua lá! Não sei ao certo o que é pior, pois o acoplamento dinâmic22o geralmente você vai ver o problema só em tempo de execução.

Claro, ele também tem suas partes boas, como poder criar pipelines em cima desses eventos, "melhorar" a quantidade de dependências que a sua classe tinha de conhecer vários outros serviços...

<img src="./images/mediator.png" width="800px"/>

### Memento - Snapshot

Design Pattern Memento, funciona basicamente como um snapshot. Seu principal objetivo é poder navegar para frente e para trás na linha do tempo de um objeto, restaurando o seu estados! E o mais importante, isso deve ser feito sem o consumidor saber detalhes da implementação.

<img src="./images/memento.png" width="800px"/>

De uma forma muito simplista, ele **pode** funcionar como `Ctrl+Z` e `Ctrl+y` no estado do seu objeto! Quando tu chamares o **Undo**, e vai voltar uma casa na nossa timeline, no caso da imagem voltaria para o **Memento 03**. E chamando o **ReUndo**, ele vai fazer o caminho contrário, como atualmente e está no **Memento 03** ele moveria o **Current Snapshot** novamente para o **Memento 04**.

### Observable

Um dos conceitos principais quando se fala de programação reativa. Seria muito custoso uma classe ficar toda hora perguntando para a outra se ela tem alguma atualização para mandar! E qual é a grande ideia que o observable resolve. Ele pede para todo mundo que quer saber quando ele for atualizado se inscrever nele, e quando ele tiver um novo vídeo ele notifica quem está na lista de inscritos.

Incluve se não conhece meu canal no Youtube, se inscreve lá: [Cristiano Cunha](http://www.youtube.com/c/CristianoRaffiCunha)

<img src="./images/observable.png" width="600px"/>

### Specification Pattern

Ter especificações, classificações, validações diferentes de uma entidade no seu código! Sendo fácil de testar, refatorar, e mudar, pois temos especificações separadas. Temos de especificação fora da nossa entidade, respeitando o princípio do Open Close Principle. Importante! Precisamos tomar cuidado para não deixar a nossa classe anêmica e colocar tudo em uma especificação. Se você não tem regras complexas e que não mudem muito, talvez não vale muito usar esse cara!

Inclusive um outro ponto legal é que podemos usar specifications de forma conjunta, usando operadores lógicos (AND, OR, NOT...)

Não é exatamente do mundo dos Design Patterns mais comuns, é um conceito que vem do DDD, mas vale muito a pena estudar sobre o Specification Pattern.