using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SaltyHasher.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Validate_FromValue_True()
        {
	        const string value = "P@$sw0Rd";
	        var saltyHash = SaltyHash.Create(value);

	        Assert.IsTrue(saltyHash.Validate(value));
        }

	    [TestMethod]
	    public void Validate_FromPregenerate_True()
	    {
		    const string hash = "E2HJhN1F3/VBR0bcU7CJ7qsjNjIzQO225cujRckk1rA=";
		    const string salt = "blmCds9MPswKZ0+tJUqwsA==";
		    const string value = "P@$sw0Rd";

		    var saltyHash = new SaltyHash(hash, salt);
		    Assert.IsTrue(saltyHash.Validate(value));		    
	    }
	}
}
