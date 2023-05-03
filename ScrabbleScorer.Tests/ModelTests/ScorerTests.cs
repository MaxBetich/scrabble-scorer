using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ScorerTests
  {
    Scorer newScorer = new Scorer();
    [TestMethod]
    public void ScorerConstructor_CreatesInstanceOfScorer_Scorer()
    {
      Assert.AreEqual(typeof(Scorer), newScorer.GetType());
    }

    [TestMethod]
    public void GetScore_ReturnsScoreAsInt_Int()
    {
      int newInt = newScorer.GetScore("scrabble");
      Assert.AreEqual(14, newInt);
    }

    [TestMethod]
    public void GetScore_ReturnsScoreForDifferentInputs_Int()
    {
      int newInt = newScorer.GetScore("scrabbles");
      Assert.AreEqual(15, newInt);
    }
  }
}

