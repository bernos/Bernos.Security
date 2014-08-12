namespace Bernos.Security
{
    public class Pbkdf2Sha1Configuration
    {
        public int SaltBytes = 24;
        public int HashBytes = 24;
        public int Pbkdf2Iterations = 1000;
    }
}