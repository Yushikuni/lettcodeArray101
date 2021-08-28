public class Solution 
{
    public void DuplicateZeros(int[] arr) 
    {
        //delka pole
        int n = arr.Length;
        //pocet duplicit
        int duplicity = 0;
        //zjisteni pocet duplicit
        for(int i = 0; i < n; ++i)
        {
            if(arr[i] == 0)
            {
               ++duplicity; 
            }
        }
        
        //uprava pole
        for(int i = n - 1; i >= 0; --i)
        {
            //pokud je index vetsi nez n tak zmensi index
            if(i + duplicity < n)
            {
                arr[i + duplicity] = arr[i];
            }
            //pokud je tam nula tak proved duplicity
            if(arr[i] == 0)
            {
                //arr[i + duplicity] = 0;
                //odecet duplicity
                duplicity--; 
                //kontrola kvuli preteceni ale asi nefunguje
                if(i + duplicity < n)
                {
                    arr[i + duplicity] = arr[i];
                }
            }
        }
    }
}

/*
postup
A:
    1. lokalizovat nuly z pole
    2. zjistit pocet nul
a to budou duplicity

B: 
    1. projet cyklus
    2. od konce smazat tolik mista kolik je duplicit
*/
