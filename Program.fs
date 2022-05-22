// Learn more about F# at http://fsharp.org

open System
type Person =
    { FirstName: string;
      LastName: string;
      Age: int;}

    
[<EntryPoint>]
let main argv =
    printfn "Assigment #1!"
    let IsEven x =  (x % 2) = 0
    let IsOdd x =  (x % 2) = 1
      
    printfn "Give me a number"
    let numberString = Console.ReadLine()
    let number = Int32.Parse(numberString)
    if  IsEven number then printfn "it's an Even"
    else printfn "It's an Odd"
 //..................................................................
    let listOfNumbers =[1; 2; 3; 4; 5; 6; 7; 8; 9; 10]

    let FindEvenNumbers() = 
        let evens anyList= 
             List.filter IsEven anyList
        printf "%A" (evens listOfNumbers)
    
    FindEvenNumbers()
//....................................
    let FirstHundredEvenSum() = 
        for c in 1 ..100 do 
           if (IsEven c) then printf "\n %A \n" c
    
    FirstHundredEvenSum()
//....................................................
    let Between()=

       let evens =[for c in 1 ..100 do if (IsEven c) then yield c*c]
       let odds =[for c in 1 ..100 do if (IsOdd c) then yield c*c]
       let sumEvens= List.fold (+) 0 evens
       let sumOdds= List.fold (+) 0 odds
       let beet = sumEvens-sumOdds
       printf "%A" beet

           


    Between()
    
    let Spliter (text : string) =
        let words = Seq.toArray text
        let spilts= [for i in 0.. words.Length-1 do 
                     if IsOdd (i+1) then yield words.[i]]
        printf "\n%A\n" spilts

            
                      
        
 
        
    Spliter("Hello")

       
    let rec sieve xs count maxNumb =        
        if count = maxNumb then xs
        else
            let xs' = if xs |> Array.contains count 
                      then xs |> Array.filter (fun ys -> ys % count <> 0. || ys = count)
                      else xs
            sieve xs' (count + 1.) maxNumb   
    
    let FindPrimesUpTo maxNumb = 
         sieve [|2. .. maxNumb|] 2. maxNumb

    

    let persons =[{FirstName= "Badar"; LastName="Lili"; Age= 22}; {FirstName= "Kiss"; LastName="Bela"; Age= 40};{FirstName= "Ano"; LastName="Nymus"; Age= 20}]
    let sumOfAges = persons |> List.sumBy (fun ages -> ages.Age  )
    printf "%A" sumOfAges

    let FindPeopleAbove x =
        let above = persons |> List.filter (fun ages ->ages.Age< x  )
        printf "%A" above



    FindPeopleAbove 50

    let FindAverageAge () =
        let average =double (persons |> List.sumBy (fun ages -> ages.Age ))
      
        printf "%A" average

    FindAverageAge()
    
    

  





    0 // return an integer exit code


       