# .NET-FacePlusPlus-V3-
FacePlusPlus V3 For .NET

# What :
C# Windows Console, C# Windows Form, .NET Web Form, .NET MVC5 examples for Face++ V3 (https://www.faceplusplus.com/) api.

# Why :
Face++ company doesnt have c# support nowly.

# How To Use :
1 - Download full files.
2 - Be member to Face++ (https://www.faceplusplus.com/)
3 - Create app from Face++ Console. Copy apikey and apisecret.
4 - Change FacePP.Service > ApiService.cs > UserInfo Area

        //for console/windows form
        private static string username = "FACEPLUSPLUS USER EMAIL"; //faceplusplus login email
        private static string password = "FACEPLUSPLUS USER PASSWORD"; //faceplusplus login password
        private static string apikey = "FACEPLUSPLUS API KEY"; //faceplusplus v3 apikey
        private static string apisecret = "FACEPLUSPLUS API SECRET"; //faceplusplus v3 apisecret
        //for console/windows form

        ////for web form/mvc
        //<add key="facepp_username" value="FACEPLUSPLUS USER EMAIL"/>
        //<add key="facepp_Password" value="FACEPLUSPLUS USER PASSWORD"/>
        //<add key="apikey" value="FACEPLUSPLUS API KEY"/>
        //<add key="apisecret" value="FACEPLUSPLUS API SECRET"/>
    
        //private static string username = System.Configuration.ConfigurationManager.AppSettings["facepp_username"];
        //private static string password = System.Configuration.ConfigurationManager.AppSettings["facepp_Password"];
        //private static string apikey = System.Configuration.ConfigurationManager.AppSettings["apikey"];
        //private static string apisecret = System.Configuration.ConfigurationManager.AppSettings["apisecret"];
        ////for web form/mvc
        
5 - Set as start choosen project and start.
6 - All layers use/need FacePP.Service layer. If doesnt necessary dont hand ApiService.cs

# Missing : 
I dont store any data about api(mssql, mysql, xml, json, sqllite...) so some services use api more than normal. 
Forexample search api, normally search api work with token but i dont store any token. 
So i coded :  detect > get detected image token > use token for search

But i will mvc example with database in this year(2017).

# Support :
kayakiranh@gmail.com, iletisim@huseyinkayakiran.com

# Final :
Sorry about bad english readme.
Thanks for interest my project.
Hüseyin Kayakıran
