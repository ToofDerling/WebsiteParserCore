﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebsiteParserCore.Attributes;
using WebsiteParserCore.Converters;

namespace WebsiteParserCore.Tests
{
    [TestClass]
    public class ConvertersTests
    {
        [TestMethod]
        public void DateTimeTest()
        {
            DateTimeConverter dtc = new DateTimeConverter();

            DateTime actual = (DateTime)dtc.Convert("2019-10-19 13:01:21");

            Assert.AreEqual(new DateTime(2019, 10, 19, 13, 1, 21), actual);
        }

        [TestMethod]
        public void DateTimeFormatTest()
        {
            DateTimeConverter dtc = new DateTimeConverter();
            dtc.Format = "HH?ss?mm MM=dd=yyyy";

            DateTime actual = (DateTime)dtc.Convert("19?21?54 10=18=2018");

            Assert.AreEqual(new DateTime(2018, 10, 18, 19, 54, 21), actual);
        }

        [TestMethod]
        public void EnumTest()
        {
            EnumConverter<TestEnum> ec = new EnumConverter<TestEnum>();

            TestEnum actual = (TestEnum)ec.Convert("Val2");

            Assert.AreEqual(TestEnum.Val2, actual);
        }

    }

    enum TestEnum
    {
        Val1,
        Val2,
        Val3
    }
}
