namespace TypeStrings
{
    internal class Program
    {

        public bool TypeStrings(string S, String T)
        {

             char[] SArray = S.ToCharArray();

            char[] TArray = T.ToCharArray();


            for (int s = 0; s < SArray.Length-1; s++)   
            {
                if (SArray[s].Equals('#')) 
                {
                    SArray[s] = ' ';
                    SArray[s -1] = ' ';

                }
            }
            String newSstring = new(SArray);
            String.Concat(newSstring.Where(c => !Char.IsWhiteSpace(c)));
           // newSstring.Replace(" ", "");

            for (int t = 0; t< TArray.Length-1; t++)
            {
                if (TArray[t].Equals('#')) 
                {
                    TArray[t] = ' ';
                    TArray[t-1] = ' ';

                }
            }
            String newTstring = new(TArray);
            String.Concat(newTstring.Where(c => !Char.IsWhiteSpace(c)));
           // newTstring.Replace(" ", "");


            if (newTstring.Equals(newSstring)){
                return true;
             }

            return false;
        }
        static void Main(string[] args)
        {
           
            Program p = new Program();
           
            Console.WriteLine(p.TypeStrings("AB##Z", "AB#Z"));



        }
    }
}