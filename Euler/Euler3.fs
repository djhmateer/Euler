// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?
module Euler3
printfn "hello3"
let Solution1() =
    // get a list of prime numbers...
    // a number is prime if it can only divide by itself and 1
    let numbers = [1..30]
    let primes = [1] 
    for i in numbers do
//        if i % 2 = 0 then 
//        else
            // add to the primes list
            let newList = i :: primes
            printfn "%A" newList
          

    

    // does 13195 / that prime number have 0 remainder.. if yes, then its a prime factor
Solution1()

