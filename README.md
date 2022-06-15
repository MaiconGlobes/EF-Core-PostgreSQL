# EFCorePostgre

O Entity Framework Core é uma ferramenta **ORM** (_Object-relational mapping_) que permite ao desenvolvedor trabalhar com dados relacionais na forma de objetos específicos.
Possui 3 maneiras de se trabalhar, sendo elas:
- _Database First_
- _Model First_
- _Code First_

O modelo apresentado nesse exemplo utiliza-se do modo Code First, tendo suas relações construidas diretamente em classes modelos e sob comando do EF aplicado ao banco de dados.

![image](https://user-images.githubusercontent.com/79027384/162597947-44e2c97d-e53a-4166-94fd-30a17d1c8242.png)

O projeto apresenta-se na arquitetura MVC, com adição da camada _Services_ conforme visto na imagem abaixo:

![image](https://user-images.githubusercontent.com/79027384/162598032-b7206de2-aacb-41b8-9158-6d8d902d3f2f.png)

Ao baixar o projeto, o mesmo virá sem dependências do EF tendo somente as estruturas básicas para o funcionamento do projeto.

![image](https://user-images.githubusercontent.com/79027384/162597957-3f6f11f8-2a5a-4d92-a876-712f177da01f.png)

A pasta **_Database_** não virá com o projeto, pois a mesma se trata de um banco de dados Postgre embarcado. Para que o projeto funcione será necessário a instalação do **__Postgre v.14__**.
Após a instalação do banco de dados, o mesmo tem por padrão o database _postgre_ e o shema _public_. Caso já tenha um banco com outro nome de database e schema, as configurações do provedor devem ser modificados na classe _Contexto.cs_ da pasta _Services_.

![image](https://user-images.githubusercontent.com/79027384/173959743-269de3b7-4e05-43fb-b3aa-7cdb89f5e8de.png)

![image](https://user-images.githubusercontent.com/79027384/162598041-ffd0acfd-695a-4fac-9f1e-74ceedb28126.png)

Em Models se encontra as classes de entidades de relacionamento, contendo 3 classes que serão inseridas ao banco e uma classe abstrata (Pessoa) para ser usada nas heranças das demais classes.

![image](https://user-images.githubusercontent.com/79027384/162598050-cdd430a6-0a7b-4786-b5f2-7bc2b7548e0f.png)

Para uso do EF Core, faz se necessário o uso dos pacotes do EF Core via NuGet. Os pacotes necessários já estão inclusos no projeto na versão 5.0.0, porém pode se usar outras versões.

![image](https://user-images.githubusercontent.com/79027384/162598082-e730b8ad-3833-470b-9072-06bad5f48809.png)

![image](https://user-images.githubusercontent.com/79027384/162598109-e9ad2980-af90-4902-ad42-569ec8661eb7.png)

Caso queira alterar ou instalar novos pacotes instale:
- _Microsoft.EntityFrameworkCore_
- _Microsoft.EntityFrameworkCore.Design_
- _Microsoft.EntityFrameworkCore.Tools_
- _NpgSql.Microsoft.EntityFrameworkCore.PostgreSQL_

![image](https://user-images.githubusercontent.com/79027384/162598143-bf05e604-c25f-4b28-b5c9-101730a99afa.png)

Após instalação dos pacotes, abrindo a pasta de _dependências_, pode ser visto os mesmos instalados:

![image](https://user-images.githubusercontent.com/79027384/162598152-dea55097-94d3-4297-acb5-51d59831fefd.png)

Conforme mencionado anteriormente nesse documento, os parâmetros de configuração do banco de dados pode ser configurado na classe **_Contexto_** conforme imagem:

![image](https://user-images.githubusercontent.com/79027384/162598164-8f1bd69a-6655-4c2f-b59a-7965824c7abf.png)

![image](https://user-images.githubusercontent.com/79027384/162646491-902cc11a-067e-493d-a87e-cca472b9fe67.png)

Com o entity Framework, a criação das entidades do banco é feita através de comandos, usando o console do NuGet coforme imagem:
![image](https://user-images.githubusercontent.com/79027384/162646558-2a2bc1ff-9e0f-4348-9ddd-dc22a7872eec.png)

Antes de criar as entidades no banco é nesessário criar os _Migrations_ que nada mais são do que dados e métodos de relação e migração com o banco. Para tal execute os comando abaixo:
- _dotnet tool install --global dotnet-ef_
- _dotnet ef migrations add InitialCreate_
- _dotnet ef database update_

Para demais comandos e aprimoramento em seus estudos, vide as documentações da EF Core e postgreSQL:

https://docs.microsoft.com/pt-br/ef/

https://www.npgsql.org/efcore/index.html
