# Amigo Secreto ![C#](https://img.shields.io/badge/c%23-%23239120.svg?logo=c-sharp&logoColor=white) ![Static Badge](https://img.shields.io/badge/6.0-blueviolet?logo=.net&logoColor=white) 

Aplicação desenvolvida em `C# Windows Form` com o intuito de gerar pares pros amigos secreto.

## 📏 Regras de negócio

- Utilizei como base a ideia do MVVM para criação e organização de pastas;
- As classes Model `Pessoa` e `AmigoSecreto` tem configuradas suas regras de negocios e foi feito o override do ToString com separação usando ";" para facilitar o salvamento no CSV e capturar com a tratativa do Split.
- As Classes `View Models` foram criadas para facilitar a tratativa que os dados irão receber e separar do Forms, para terem maior autonomia dos dados e separar as funções do negócio das funções do sistema.
- O `Form1` está a parte principal do projeto, onde o usuário pode adicionar o nome e o email, porém, o email é opcional, caso queira, o mesmo pode adicionar apenas nome e sobrenome e o email será gerado automáticamente.
- o `FormAmigoSecreto` foi feito mais pela questão de visualização dos dados e ter uma ideia do que está gerando de forma organizada, já que o mesmo deve ser sigiloso até o fim do evento.
- A classe `Persistencia` é essencial para a conexão, leitura e escrita com os CSVs, usei uma ideia semelhante a de como capturar dados de banco de dados pra facilitar a leitura do mesmo.
- A classe `Utils` tem métodos auxiliares, para validação de email e geração do mesmo, para poder ser acessado em momentos necessários do codigo.

## 🔧 Recursos Utilizados

- ``.NET 6``
- ``C#``

## 🔻 Clonar Repositório

```bash
git clone git@github.com:OQueLucas/SalesWebMvc.git
```

## 👨🏻‍🦱 Author
[Lucas Queiroz](https://github.com/OQueLucas/)
