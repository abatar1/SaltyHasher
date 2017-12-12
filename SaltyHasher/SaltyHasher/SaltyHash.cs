namespace SaltyHasher
{
    public class SaltyHash
    {
		public string Salt { get; }
		public string Hash { get; }

	    public SaltyHash(string hash, string salt)
	    {
		    Salt = salt;
		    Hash = hash;
	    }

	    public static SaltyHash Create(string value)
	    {
		    var salt = SaltyHasher.Salt.Create();
		    var hash = SaltyHasher.Hash.Create(value, salt);
		    return new SaltyHash(hash, salt);
	    }

	    public bool Validate(string value) =>
		    SaltyHasher.Hash.Validate(value, Salt, Hash);
    }
}
