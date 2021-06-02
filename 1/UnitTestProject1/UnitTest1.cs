using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp2;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //к 1-ому заданию 1-я проверка
        [TestMethod]
        public void quest1_n10_return_не_простое_1()
        {
            //arange
            int n = 25;
            string answer = "не простое";

            //act
            quest1 q = new quest1();
            string value = q.quests(n);

            //assert
            Assert.AreEqual(answer, value);
           
        }
        
        //к 1-ому заданию 2-я проверка
        [TestMethod]
        public void quest1_n10_return_не_простое_2()
        {
            //arange
            int n = 30;
            string answer = "не простое";

            //act
            quest1 q = new quest1();
            string value = q.quests(n);

            //assert
            Assert.AreEqual(answer, value);
           
        }
        
        //к 1-ому заданию 3-я проверка
        [TestMethod]
        public void quest1_n10_return_не_простое_3()
        {
            //arange
            int n = 50;
            string answer = "не простое";

            //act
            quest1 q = new quest1();
            string value = q.quests(n);

            //assert
            Assert.AreEqual(answer, value);
           
        }
        
        //к 1-ому заданию 4-я проверка
        [TestMethod]
        public void quest1_n10_return_простое_1()
        {
            //arange
            int n = 31;
            string answer = "простое";

            //act
            quest1 q = new quest1();
            string value = q.quests(n);

            //assert
            Assert.AreEqual(answer, value);
           
        }
        
        //к 1-ому заданию 5-я проверка
        [TestMethod]
        public void quest1_n10_return_простое_2()
        {
            //arange
            int n = 19;
            string answer = "простое";

            //act
            quest1 q = new quest1();
            string value = q.quests(n);

            //assert
            Assert.AreEqual(answer, value);
           
        }
        
        //к 1-ому заданию 6-я проверка
        [TestMethod]
        public void quest1_n10_return_простое_3()
        {
            //arange
            int n = 23;
            string answer = "простое";

            //act
            quest1 q = new quest1();
            string value = q.quests(n);

            //assert
            Assert.AreEqual(answer, value);
           
        }

        
        // к 3-му заданию (без рекурсии)_1
        [TestMethod]
        public void fibonachi_int_10_answer_55()
        {
            //arange
            int n = 10;
            int answer = 55;

            //act
            fibonachi feb = new fibonachi();
            int ans = feb.fibonachis(n);

            //assert
            Assert.AreEqual(answer, ans);

        }
        
        // к 3-му заданию (без рекурсии)_2
        [TestMethod]
        public void fibonachi_int_17_answer_1597()
        {
            //arange
            int n = 17;
            int answer = 1597;

            //act
            fibonachi feb = new fibonachi();
            int ans = feb.fibonachis(n);

            //assert
            Assert.AreEqual(answer, ans);

        }
        
        // к 3-му заданию (без рекурсии)_3
        [TestMethod]
        public void fibonachi_int_36_answer_14930352()
        {
            //arange
            int n = 36;
            int answer = 14930352;

            //act
            fibonachi feb = new fibonachi();
            int ans = feb.fibonachis(n);

            //assert
            Assert.AreEqual(answer, ans);

        }
        
        // к 3-му заданию с рекурсией_4
        [TestMethod]
        public void fibonachirecurs_int_15_answer_610()
        {
            //arange
            int n = 15;
            int answer = 610;

            //act
            fibonachi feb = new fibonachi();
            int ans = feb.fibonachirecurs(n);

            //assert
            Assert.AreEqual(answer, ans);

        }
        
        // к 3-му заданию с рекурсией_5
        [TestMethod]
        public void fibonachirecurs_int_20_answer_6765()
        {
            //arange
            int n = 20;
            int answer = 6765;

            //act
            fibonachi feb = new fibonachi();
            int ans = feb.fibonachirecurs(n);

            //assert
            Assert.AreEqual(answer, ans);

        }
        
        // к 3-му заданию с рекурсией_6
        [TestMethod]
        public void fibonachirecurs_int_10_answer_55()
        {
            //arange
            int n = 10;
            int answer = 55;

            //act
            fibonachi feb = new fibonachi();
            int ans = feb.fibonachirecurs(n);

            //assert
            Assert.AreEqual(answer, ans);

        }
        
    }
}
