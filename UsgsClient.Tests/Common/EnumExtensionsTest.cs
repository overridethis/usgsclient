using System;
using System.ComponentModel;
using UsgsClient.Common;
using Xunit;

namespace UsgsClient.Tests.Common
{
    public class EnumExtensionsTest
    {
        [Fact]
        public void GetAttributeOfType_can_retrieve_description_attribute()
        {
            // Arrange.
            var one = ForTest.One;

            // Act.
            var attr = one.GetAttributeOfType<DescriptionAttribute>();

            // Assert.
            Assert.NotNull(attr);
        }

        [Fact]
        public void GetAttributeOfType_returns_null_when_attr_not_found()
        {
            // Arrange.
            var two = ForTest.Two;

            // Act.
            var attr = two.GetAttributeOfType<DescriptionAttribute>();

            // Assert.
            Assert.Null(attr);
        }

        [Fact]
        public void GetDescription_returns_description_text()
        {
            // Arrange.
            var one = ForTest.One;
            var expected = "Description_for_one";

            // Act.
            var actual = one.GetDescription();

            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDescription_returns_null_when_attr_not_found()
        {
            // Arrange.
            var two = ForTest.Two;

            // Act.
            var actual = two.GetDescription();

            // Assert.
            Assert.Null(actual);
        }

        public enum ForTest
        {
            [Description("Description_for_one")]
            One,
            Two
        }
    }
}
