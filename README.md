# CursoRazorPages
Arquivos do curso de RazorPage (Udemy) [https://www.udemy.com/course/advanced-aspnet-core-3-razor-pages]

#### Processo
1) Adcione o pacote abaixo.
```sh
$ install-package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
```
2) Altere o arquivo **startup.cs** para conter a linha abaixo em **ConfigureServices**.
```sh
$ services.AddRazorPages().AddRazorRuntimeCompilation();
```
3) Selecione os projetos **Taste.Models** e **Taste.DataAccess** e insira o seguinte pacote em **Nuget for Solution**.
```sh
$ install-package Microsoft.AspNetCore.Identity.EntityFrameworkCore
```
4) Selecione somente o projeto **Taste.DataAccess** e insira o seguinte pacote em **Nuget**.
```sh
$ install-package Microsoft.EntityFrameworkCore.SqlServer
```
5) Selecione os projetos **Taste.Models** e **Taste.DataAccess** e insira o seguinte pacote em **Nuget for Solution**.
```sh
$ install-package Microsoft.AspNetCore.MVC
```
6) Selecione os projetos **Taste.Web** e **Taste.DataAccess** e insira o seguinte pacote em **Nuget for Solution**.
```sh
$ install-package Stripe.net
```
7) Mova a pasta `Migrations` de **Taste.Web** para **Taste.DataAccess** e exclua a pasta de **Taste.Web**.
8) Exclua o conteudo da pasta `Migrations` do projeto **Taste.DataAccess**.
9) Mova a classe `ApplicationDbContext` da pasta `Data` **Taste.Web** para **Taste.DataAccess**. 
10) Delete a pasta Data de **Taste.Web**. 
11) Corrija o namespace de `ApplicationDbContext`. 
12) Crie em  **Taste.DataAccess** as pastas `Initialize` e `Repository` e dentro de `Repository` a pasta `IRepository`.
13) De  **Taste.DataAccess** exclua o arquivo `Class1.cs`
14) De  **Taste.Models** crie a pasta `ViewModels`
15) Acesse o site [Bootswatch](https://bootswatch.com) e escolha um tema, e faça o downlaod de `bootstrap.css` desse tema.
16) Acrescentando opção de usar **MVC** no projeto.
17) Acrescendando [jqueryui.com](https://jqueryui.com/) ao projeto.
18) Acrescendando [datatables.net](http://datatables.net/) ao projeto.
19) Acrescendando [fontawesome.com](https://fontawesome.com/) ao projeto.
19) Acrescendando [Toastr](https://codeseven.github.io/toastr/) ao projeto. 
- Tem o CDN do Toastr [aqui](https://cdnjs.com/libraries/toastr.js/latest).
20) Acrescendando [Sweet Alert](https://sweetalert.js.org/guides/#installation) ao projeto. 
21) Adcionando o [Tiny Docs](https://www.tiny.cloud/docs/demo/full-featured/) ao projeto.
- Tem o CDM do Tiny Docs [aqui](https://www.tiny.cloud/my-account/dashboard).
22) Adicionando [jquery.timepicker](http://www.jonthornton.com/jquery-timepicker/) ao projeto.

