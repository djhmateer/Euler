// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?
module Euler3
open System

let Solution1() =
    // Prime number generator - it can only divide by itself and 1
    let primes maxPrime =
         [for i in [3..2..maxPrime] do
            let divisors = [3..2..i/2-1]
            let mutable isPrime = true
            for j in divisors do
                if i % j = 0 then
                    isPrime <- false
            if isPrime then
                yield i]

    // largest prime factor.. notice I on the end to denote a bigint
    let num = 600851475143I
    let maxPrime = (int64(sqrt(double num)))
    printfn "%A" maxPrime
    let maxPrimeInt = int(maxPrime)
    for i in primes maxPrimeInt do
        if num % (bigint(i)) = 0I then
            printfn "%i is a factor" i
    // 6857
//Solution1()

//http://theburningmonk.com/2010/09/project-euler-problem-3-solution/
let Solution2() =
    // takes a int64, returns a sequence of int64
    let findFactorsOf(n:int64) =
        let upperBound = int64(Math.Sqrt(double(n)))
        [2L..upperBound] 
        |> Seq.filter (fun x -> n % x = 0L)
        // collect is like LINQ SelectMany
        |> Seq.collect (fun x-> [x; n/x])
 
    // this only gives 2,3 for findFactorsOf 12
    let stuff = findFactorsOf(12L)
    printfn "%A" stuff

    let isPrime(n:int64) = findFactorsOf(n) |> Seq.length = 0
 
    let findMaxPrimeFactorOf(n:int64) =
        findFactorsOf(n)
        |> Seq.filter isPrime
        |> Seq.max
 
    printfn "%A" (findMaxPrimeFactorOf(600851475143L))
//Solution2()

//http://geekswithblogs.net/MarkPearl/archive/2010/06/21/f-euler-problem-3.aspx
let Solution3() =
    let isPrime (number : bigint) =
        match number with        
            | _ -> seq { bigint(2) .. bigint(1) .. bigint (Math.Sqrt (float number))}    
                |> Seq.exists (fun x -> if (number % x = bigint(0)) then true else false)      
                |> not  
     
    // for 30 it is:  2,3,4,5           
    let potentialDivisors = seq { bigint(2) .. bigint(1) .. bigint (Math.Sqrt (float 30))}
    printfn "%A" potentialDivisors 
    
    let potentialEvenDivisors =
        potentialDivisors
        |> Seq.exists (fun x -> if (30I % x = bigint(0)) then true else false)    
        |> not  

    printfn "%A" potentialEvenDivisors
       
    //printfn "%A" (isPrime(2I))
    //printfn "%A" (isPrime(4I))

    // Returns a sequence of prime numbers up to number x
    let primenumbersOf (number : bigint) =    
        let oddPrimes = 
            seq { bigint(3).. bigint(2) .. number} 
            |> Seq.filter(fun x -> isPrime x)                
        Seq.append [bigint(2)] oddPrimes

//    printfn "%A" (primenumbersOf(20I))
    printfn ""
//Solution3()

let S4() =
    let is_prime x =
        let rec check i =
            double i > sqrt (double x) || (x % i <> 0L && check (i + 1L))
        check 2L                
 
    let big_number_factors n =
        let factors = seq {
            let limit = n / 2L
            for i in 2L .. limit do
                if n % i = 0L && is_prime i then yield i }
        Seq.max factors

    printfn "%A" (big_number_factors(200L))
//S4()

let output x = printfn "%A" x

// The prime divisors of 13195 are 5, 7, 13 and 29.
let S5() =
    let divisorsOf n =
        // make a sequence 2,3,4,5.. up to sqrt of n
        [2L..int64 (sqrt(double(n)))] 
        // get every number in the sequence which divides by n
        |> Seq.filter (fun x -> n % x = 0L)

    let isPrime n = divisorsOf(n) |> Seq.length = 0

    let findMaxPrimeFactorOf n =
        divisorsOf n
        |> Seq.filter isPrime
        |> Seq.max
  
    let maxPrime = findMaxPrimeFactorOf(600851475143L)
    let maxPrime = findMaxPrimeFactorOf(13195L)

    printfn "%A" maxPrime
S5()


