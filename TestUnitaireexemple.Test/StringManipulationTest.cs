using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUnitaireExemple.Exceptions;
using TestUnitaireExemple.Models;

namespace TestUnitaireexemple.Test
{
    public class StringManipulationTest
    {
        [Fact(DisplayName ="Simple Palindrome")]
        [Trait("Category","StringManipulation - Palindrome")]
        [Trait("Category", "Positif")]
        public void SimplePalindromeTest()
        {
            string leMot = "kayak";

            bool retour = StringManipulation.IsPalindrome(leMot);
            Assert.True(retour);
        }
        [Fact(DisplayName = "Simple Palindrome")]
        [Trait("Category", "StringManipulation - Palindrome")]
        [Trait("Category", "Negatif")]
        public void NotAPalindromeTest()
        {
            string leMot = "abc";

            bool retour = StringManipulation.IsPalindrome(leMot);
            Assert.False(retour);
        }


        [Theory(DisplayName = "Doit détecter les palyndrome avec différents casses")]
        [InlineData("Aba", true)]
        [InlineData("AbA", true)]
        [InlineData("Hello", false)]
        [Trait("Category", "StringManipulation - Palindrome")]
        [Trait("Category", "Positif-Negatif")]
        public void PalindromeWithCasse(string input, bool exceptedvalue)
        {
            bool retour =StringManipulation.IsPalindrome(input);
            Assert.Equal(exceptedvalue, retour);
        }








        [Fact(DisplayName = "One character")]
        [Trait("Category", "StringManipulation - Palindrome")]
        [Description("Un palyndrome ne peut pas être d'1! caractère")]
        [Trait("Category", "Exception")]
        public void OneCharacterPalindromeTest()
        {
            string leCaractere = "a";
            Assert.Throws<CanNotBeASingleCharacterException>(() => StringManipulation.IsPalindrome(leCaractere));
            
        }
        [Fact(DisplayName = "Empty character not authorized")]
        [Trait("Category", "StringManipulation - Palindrome")]
        [Description("Un palyndrome ne peut pas être une chaine vide ")]
        [Trait("Category", "Exception")]
        public void EmptyPalindromeTest()
        {
            string leCaractere = "";
            Assert.Throws<CanNotBeEmptyOrNullException>(() => StringManipulation.IsPalindrome(leCaractere));

        }
        [Fact(DisplayName = "Null not authorized")]
        [Trait("Category", "StringManipulation - Palindrome")]
        [Description("Un palyndrome ne peut pas être null")]
        [Trait("Category", "Exception")]
        public void NullPalindromeTest()
        {
            string leCaractere = null;
            Assert.Throws<CanNotBeEmptyOrNullException>(() => StringManipulation.IsPalindrome(leCaractere));

        }

        [Theory(DisplayName = "Doit tester le maximum de caractère : 20")]
        [Trait("Category", "StringManipulation - Palindrome")]
        [Description("Les chaines de caractère testées ne peuvent dépasser 20 caractères")]
        [InlineData("Aba", true)]
        [InlineData("aaaaaaaaaa", true)]
        [InlineData("azaaaaaaaaaaaaaaaaza", true)]
        [InlineData("azaaaaaaaaaaaaaaaaaaza", false)]
        [Trait("Category", "Positif - Negatif")]
        public void AlphaAndNonAlphaPalindromeTest(string input, bool exceptedvalue)
        {
            bool retour = StringManipulation.IsPalindrome(input);
            Assert.Equal(exceptedvalue, retour);

        }
    }
}
