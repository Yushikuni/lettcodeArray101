public class Solution 
{
    public void DuplicateZeros(int[] arr) 
    {
        //delka pole
        int n = arr.Length;
        //pocet duplicit
        int duplicity = 0;
        //hlavni smycka
        for(int i = 0; i < n; ++i)
        {
            if(arr[i] == 0)
            {
               ++duplicity; 
            }
        }
        
        //kopie
        for(int i = n; i >= 0; --i)
        {
            if(arr[i] == 0)
            {

                //Insert(arr[i+duplicity],0);
                //arr[i + duplicity] = 0;
                duplicity--;
            }
            else
            {
                arr[i + duplicity] = arr[i];
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
