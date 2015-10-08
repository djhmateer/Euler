// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?
module Euler3
open Microsoft.FSharp.Math

let Solution1() =
    // get a list of prime numbers...
    // a number is prime if it can only divide by itself and 1
    let numbers = [1..7000]
    // A generator
    let primes =
         [for i in numbers do
            if i % 2 <> 0 then
                let divisors = [3..2..i-1]
                let mutable isPrime = true
                for j in divisors do
                    if i % j = 0 then
                        isPrime <- false
                if isPrime then
                    yield i]

    // largest prime factor.. notice I on the end to denote a bigint
    let bigNum = 600851475143I
    for i in primes do
//        let x = bigint 10
        let bigInt (x:int) = bigint(x)
        if bigNum % (i |> bigInt) = 0I then
            printfn "%i is a factor" i

    // does 13195 / that prime number have 0 remainder.. if yes, then its a prime factor
    // 6857
Solution1()

