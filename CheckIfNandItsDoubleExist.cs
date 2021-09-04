public class Solution 
{
    //naivní přístup (nejpřímočařejnší přístup k řešení problému)
    public bool CheckIfExist(int[] arr) 
    {
        //defenzivní programování, pole bude mít alespoň dva prvky
        if (arr == null || arr.Length == 0) 
        {
             return false;
        }
        //funguje pro všechny případy, kdy by v poli 
        for (int i = 0; i < arr.Length ; ++i) 
        {
            for(int j = 0; j < arr.Length; ++j)
            {
                if(i != j)
                {
                   /* //specílní případ pro nulu
                    if(arr[i] == 0 && arr[j] == 0)
                    {
                        return false;
                    }
                    */
                    if(arr[i] == 2*arr[j])// || arr[i] % 2 == 0)
                    {
                        return true;
                    }
                    
                }
            }
        }        
        return false;
    }
}
//druhé řešení pro rychlost na šetření úkor paměti
/*
dělá se to přes slovník
Slevník umožnuje ukládat tzv. Klíče (index) index = arr[i];
Pak by mi stačil jeden cyklus for [nacházá se na klíči arr[i] / 2]
Proč by měli býti řazeny od nejmeší prvků? Res. Poslední hodnota by měla být nejmenší, aby se zvětšila šance že budu znát alespoň jeden prvek co je větší
Sekvence musí být seřana sestupně (od největšího po nejmenší)

nebo využití datových strukutur
hash map (a dictionary je stejné)
výhoda je v tom, že má konstantní rychlost
nevýhoda je velikost (ukládám hashe)
*/
