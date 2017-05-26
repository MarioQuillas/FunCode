let rec allPermutations charList = 
    seq {
        match charList with
        | [] -> yield ""
        | head::tail -> 
            let pivotPermutations = allPermutations(tail)
            let length = charList.Length
            for i in 0 .. length - 1 do
                for word in pivotPermutations do
                    yield word.Insert(i, head.ToString())
    }

let allWordPermutations (word:string) =
    let t = word.ToCharArray() :> seq<char> 
    allPermutations (List.ofSeq t)

let printAllWordPermutations word =
    for w in allWordPermutations(word) do
        printfn "%s" w