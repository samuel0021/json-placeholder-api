
## 1. Leitura básica (GET)

- Buscar todos os posts (`GET /posts`) e imprimir no console apenas `id` e `title` dos 10 primeiros.[^2][^1]
- Buscar um post específico por id (`GET /posts/10`) e exibir todos os campos.[^1][^2]
- Buscar todos os usuários (`GET /users`) e mostrar nome, email e cidade (campo `address.city`).[^2][^1]


## 2. Filtros e relacionamentos

- Buscar todos os posts de um usuário específico (`GET /posts?userId=1`) e listar os títulos.[^3][^2]
- Dado um `postId`, buscar os comentários via:
    - `GET /posts/{id}/comments`
    - `GET /comments?postId={id}`
e confirmar que o conteúdo é equivalente.[^3][^2]
- Montar um método que, recebendo um `userId`, busque:
    - os posts desse usuário
    - e os respectivos comentários de cada post, retornando uma estrutura em memória (ex.: `UserPostsWithComments`).[^1][^2][^3]


## 3. CRUD simulado com posts

- Criar um método `CreatePostAsync(Post post)` que faça `POST /posts`, envie um JSON com `title`, `body`, `userId` e imprima o JSON de resposta (lembrando que a API não persiste de verdade).[^4][^1]
- Criar um método `UpdatePostAsync(int id, Post post)` que faça `PUT /posts/{id}` e valide se o corpo retornado reflete as alterações.[^4][^1]
- Criar um método `PatchPostTitleAsync(int id, string title)` que faça `PATCH /posts/{id}` alterando apenas o título e mostrando a diferença entre o original e o modificado.[^1]
- Criar um método `DeletePostAsync(int id)` que faça `DELETE /posts/{id}`, valide o `StatusCode` de sucesso e logue uma mensagem “simulado: post {id} deletado”.[^5][^1]


## 4. Todos e regras de negócio

- Consumir `GET /todos` e:
    - contar quantos todos estão concluídos (`completed = true`);
    - listar os 5 primeiros pendentes de um usuário específico (`userId`).[^2][^1]
- Implementar um método `MarkTodoAsCompletedAsync(int id)` que faça um `PATCH /todos/{id}` mudando `completed` para `true` e exibindo o objeto retornado.[^5][^1]


## 5. Tratamento de erros e robustez

- Criar testes que chamem rotas inválidas (ex.: `GET /postsss`, `GET /posts/999999`) e:
    - tratem status de erro sem quebrar a aplicação;
    - exibam mensagens amigáveis no console.[^6][^1]
- Implementar um wrapper que sempre:
    - loga a URL, método e status code;
    - mede o tempo da requisição;
    - tenta desserializar o JSON e trata exceções de forma centralizada.[^6]

Se quiser, na próxima mensagem dá para pegar uma dessas trilhas (por exemplo, “CRUD de posts” ou “relacionamento usuários/posts/comments”) e montar as interfaces e assinaturas dos métodos já em C\# bem alinhados com o que você começou.
<span style="display:none">[^10][^11][^12][^13][^14][^15][^16][^7][^8][^9]</span>

<div align="center">⁂</div>

[^1]: https://jsonplaceholder.typicode.com/guide/

[^2]: https://jsonplaceholder.typicode.com

[^3]: https://imasters.com.br/javascript/como-criar-uma-fake-api-rest-para-testes-jsonplaceholder

[^4]: https://schulich.libguides.com/c.php?g=740150\&p=5340549

[^5]: https://apichallenges.eviltester.com/practice-sites/jsonplaceholder

[^6]: https://learn.microsoft.com/pt-br/dotnet/fundamentals/networking/http/httpclient

[^7]: https://dev.to/avinashrepo/simple-task-list-application-187d

[^8]: https://codesandbox.io/examples/package/jsonplaceholder

[^9]: https://stackblitz.com/edit/js-8tc4sw

[^10]: https://jsonplaceholder.dev/examples/

[^11]: https://comunity.gitbook.io/learning.comunityplatform/toolkit-tutorials/apis/json-placeholder-todos-api-integration-in-a-simple-blog-app

[^12]: https://jsonplaceholder.org

[^13]: https://app.beeceptor.com/mock-server/json-placeholder

[^14]: https://www.youtube.com/watch?v=bMMd7sawawQ

[^15]: https://github.com/victorcastro/JSONPlaceholder-example

[^16]: https://reqbin.com/o0tzomnc

