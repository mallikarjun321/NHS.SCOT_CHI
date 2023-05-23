using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace NSS_ChildHealth.Common
{
    //[Binding]
    public class BaseTest
    {

        //protected IWebDriver Driver;
        //public static string Url;

        //private  void LoadConfigValues()
        //{
        //    Url = "http://the-internet.herokuapp.com/login";
        //}

        //[Before]
        //protected  void SetUp()
        //{
        //    LoadConfigValues();

        //    //ChromeOptions chromeOptions = new ChromeOptions();
        //    //chromeOptions.AddArguments("start-maximized");
        //    Driver = new ChromeDriver();

        //    //string filePath = "C:\\Users\\jemerson20\\source\\repos\\SpecFlow_NUnit_WD2\\MyProject.Specs\\Drivers";
        //    //Driver = new ChromeDriver(filePath, chromeOptions);
        //}

        ////Quit webdriver when test(s) are complete
        //[AfterScenario]
        //protected void TearDown()
        //{
        //    Driver.Quit();
        //}
    }
}
