# CursoRazorPages
Arquivos do curso de RazorPage (Udemy) [https://www.udemy.com/course/advanced-aspnet-core-3-razor-pages]

#### Processo
1) Adcione o pacote abaixo
```sh
$ install-package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
```
2) Altere o arquivo **startup.cs** para conter a linha abaixo em **ConfigureServices**
```sh
$ services.AddRazorPages().AddRazorRuntimeCompilation();
```
3) Selecione os projetos **Taste.Models** e **Taste.DataAccess** e insira o seguinte pacote em **Nuget for Solution**
```sh
$ install-package Microsoft.AspNetCore.Identity.EntityFrameworkCore
```
4) Selecione somente o projeto **Taste.DataAccess** e insira o seguinte pacote em **Nuget**
```sh
$ install-package Microsoft.EntityFrameworkCore.SqlServer
```