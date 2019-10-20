using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace N11TestProject
{
    [TestClass]
    public class N11Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Google Chrome’un açılması için yapıyoruz. Aynı zamanda driver diye nesne tanımlamış olduk. Bu nesne üzerinden işlemleri yapacağız.
            IWebDriver driver = new ChromeDriver(); 

            // Bu driver nesnesi ile gitmek istediğimiz sayfayı göstereceğiz.
            driver.Navigate().GoToUrl("https://www.n11.com/");

            // O adreste nereye hangi işlemin gerçekleşeceğini tanımladık.
            driver.FindElement(By.Name("bilgisayar")).SendKeys("OpenQA.Selenium");
          
            //İşlem gerçekleşirse oluşacak çıktıyı buraya yazıyoruz.
            Console.WriteLine("Yazdığım yazı ekrana geldi."); 
            
            driver.Quit(); //Açtığımız Google Chrome’u kapattık ve test işlemini sona erdirdik.
        }
    }
}