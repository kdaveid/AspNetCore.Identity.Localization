# ASP.NET Core Identity Localization

A localization library for [ASP.NET Core Identity](https://github.com/aspnet/Identity). You can copy&paste all resource files to get started with English and German. 
This library is based on the VS 2017 template and only edited for localization.   

Use this project to see how...
- View Localization 
- Controller Localization
- ViewModel Localization  

... works. 

### Screenshot
![image](misc/image.gif)


### Changes to VS 2017 templates

Besides the `@Localizer["key"]` changes within the views only the ViewModel of `LoginViewModel.cs` has been changed: a user name property has been added. You can delete the `Username` or `Email` property to fit you needs.

### Edit the resource files

When working with resource files `.resx` I strongly reccommend the `ResX Resource Manager` plugin for Visual Studio from Tom Englert. You find it in the [Market Place](https://marketplace.visualstudio.com/items?itemName=TomEnglert.ResXManager).

### How to contribute

Feel free to add additional languages. :)
For details see [contributing](./CONTRIBUTING.md).

