# Design Patterns

Design Patterns são padrões, formas de resolver problemas comuns da programação, independente de linguagem, mas em alguns casos mais focados no paradigma de OOP. Um dos seus grandes benefícios é ter uma forma comum e pronta de resolver um problema específico, isso facilita muito a comunicação e ambientação de outras pessoas na equipe.

<img src="https://springframework.guru/wp-content/uploads/2015/04/9780201633610.jpg" width="150px"></img>

Quando se fala de Design Patterns não podemos deixar de falar sobre o GOF(Gang Of Four), basicamente foram os responsáveis por organizar em um livro os principais desogn patterns usados na época(e ainda são muito usados), certamente vocÊe já viu esse livro circulando por ai, nele você vai encontrar 23 padrões de projetos, mas, na prática existem muitos outros que não estão lá.

## Classificação

Podemos dividir os Design Patterns em três conjuntos: Criacionais, Estruturais e Comportamentais.

<img src="https://res.cloudinary.com/practicaldev/image/fetch/s--kCLRYrmn--/c_limit%2Cf_auto%2Cfl_progressive%2Cq_auto%2Cw_880/https://www.lambdatest.com/blog/wp-content/uploads/2021/03/Behavioral-Design-Patterns.png" width="450px"></img>

### Criacionais

A grande ideia aqui é abstrair e facilitar o processo de criação de objetos, a criação de uma nova instância, abstraindo e facilitando o processo de instanciar objetos complexos. E o mais legal é que essa categoria de padrões pode trabalhar com configuração statica(hard coded), ou configurações dinâmicas, buscando dados para se configurar em um banco, um arquivo...

[Exemplos de código 🗂️](./1-Criasionais/)

#### Singleton

Vamos iniciar com um dos mais controversos, ele pode nos dar muitas dores de cabeça para situações onde nosso código roda em mais de uma thread, e também em casos de testes de unidade, pois acaba sendo muito difícil de colocar um duble de teste em seu lugar.

Na prática, a sua ideia é garantir que exista apenas uma instância do objeto em toda sua aplicação. É muito prático em situações onde todos os usuários de uma classe precisam usar das mesmas informações.

#### Factory Method

#### Abstract Factory

#### Builder

#### Prototype

---

### Estruturais

[Exemplos de código 🗂️](./2-Estruturais/)

### Comportamentais

[Exemplos de código 🗂️](./3-Comportamentais/)
