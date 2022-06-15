using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hola a todos";
    }
    [WebMethod]
    public int fibonacciN(int n)
    {
        int a = -1, b = 1, c = 0;
        for (int i = 0; i < n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }
     [WebMethod]
    public int fiboRecu(int n)
    {
         if ( n == 0 || n == 1 ){
             return n;
         }else{
             return fiboRecu(n-1)+ fiboRecu(n-2);
         }
        
    }
}

