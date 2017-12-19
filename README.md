##### Design Patterns (Padrões de Projeto)     
[![N|MFYIT](https://contrib.azurewebsites.net/mfyit_card.png)](http://mfyit.azurewebsites.net) 


# Chain of Responsibility 

> Em Orientação a Objetos, Chain of Responsibility é um padrão GOF cuja principal função é evitar a dependência entre um objeto receptor e um objeto solicitante. Consiste em uma série de objetos receptores e de objetos de solicitação, onde cada objetos de solicitação possui uma lógica interna que separa quais são tipos de objetos receptores que podem ser manipulados. O restante é passado para o próximo objetos de solicitação da cadeia.

> Devido à isso, é um padrão que utiliza a ideia de baixo acoplamento por permitir que outros objetos da cadeia tenham a oportunidade de tratar uma solicitação.

### Estrutura

> * A base mantém um ponteiro como "próximo";
> * Cada classe derivada implementa sua própria contribuição para manusear o pedido (request);
> * Se o pedido precisa ser passado para outra classe, então a classe derivada "chama de volta" à classe padrão, delegando um novo ponteiro;
> * O cliente (terceirizado ou não) cria e encadeia a cadeia, a qual pode incluir uma ligação do último nó até o nó da raiz;
> * O cliente lança e deixa cada request com a raiz da cadeia;
> * As delegações recursivas produzem um efeito de ilusão;

### Situações de Uso
* Mais de um objeto pode tratar uma solicitação e o objeto que a tratará não é conhecido a priori;
* O objeto que trata a solicitação deve ser escolhido automaticamente;
* Deve-se emitir uma solicitação para um dentre vários objetos, sem especificar explicitamente o receptor;
* O conjunto de objetos que pode tratar uma solicitação deveria ser especificado dinamicamente.
> Em um sistema orientado a objetos esses interagem entre si através de mensagens, e o sistema necessita de determinar qual o objeto que irá tratar a requisição. O padrão de projeto Chain of Responsibility permite determinar quem será o objeto que irá tratar a requisição durante a execução. Cada objeto pode tratar ou passar a mensagem para o próximo na cascata.

> Em um escritório, por exemplo, onde se tem 4 linhas telefônicas, a primeira linha é o primeiro objeto, a segunda linha é o segundo, e assim sucessivamente até a gravação automática que é o quinto objeto. Se a primeira linha estiver disponível ela irá tratar a ligação, se não ela passa a tarefa para o próximo objeto, que é a segunda linha. Se essa estiver ocupada ela passa a tarefa para a próxima e assim sucessivamente até que um objeto possa tratar a tarefa.

> Nesse caso, se todas as linhas estiverem ocupadas o último objeto, que é a gravação automática, tratará da tarefa.

---

## Installation

- Download the latest .NET Core SDK

* [.NET Core 2.0 SDK](release-notes/download-archives/2.0.3.md)

### Clone

- Clone this repo to your local machine using `https://github.com/BrunoLopes/Xperiments.DesignPatterns.Interpreter`

### Setup



> Restore all the packages first

```shell
$ dotnet restore
```

> now build the project

```shell
$ dotnet build
```
---

## Support

Reach out to me at one of the following places!

- Website:  [![Awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](http://mfyit.azurewebsites.net)
- Email: emfyit@gmail.com

---

## Donations (Optional)

[![Support via Gratipay](https://cdn.rawgit.com/gratipay/gratipay-badge/2.3.0/dist/gratipay.png)](https://liberapay.com/brunolopes/donate)


---

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright MFY IT 2017 © 
[![N|MFYIT](https://contrib.azurewebsites.net/mfyit_card.png)](http://mfyit.azurewebsites.net) 
