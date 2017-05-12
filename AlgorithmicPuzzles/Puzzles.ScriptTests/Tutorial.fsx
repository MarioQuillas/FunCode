let rnd = new System.Random()



let rec allPermutations charList = 
    match charList with
    | [] -> ""
    | head::tail -> 
        let pivotPermutations = allPermutations(tail)
