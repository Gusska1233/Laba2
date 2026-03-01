// Палехов Виктор БАС-1-2024 6 Вариант ЯПы
open System

// 1 Задание -------------------------------------------------
(*
let generateList count = 
    [
        for i in 1..count do
            printfn "Введите ЧИСЛА для формирования списка: "
            let ch = Console.ReadLine() |> int
            yield ch
    ]

let maxDigit number =
    let rec loop currentNumber maxElement = 
        if currentNumber >= 0 then
            if currentNumber = 0 then 
                maxElement
            else 
                let lastDigit = currentNumber % 10
                let newDigit = 
                    if lastDigit > maxElement then 
                        lastDigit 
                    else 
                        maxElement
                loop (currentNumber / 10) newDigit
        else
            let positiveNumber = -currentNumber
            if positiveNumber = 0 then 
                maxElement
            else 
                let lastDigit = positiveNumber % 10
                let newDigit = 
                    if lastDigit > maxElement then 
                        lastDigit 
                    else 
                        maxElement
                loop (positiveNumber / 10) newDigit
    loop number 0

[<EntryPoint>]
let main args =
    printfn "Формирование списка чисел list1 с 5 значениями"
    let list1 = generateList 5
    printfn "Исходный список: %A" list1

    let newList = List.map maxDigit list1
    printfn "Список с макс цифрой в числе каждого элемента списка: %A" newList
    0
    *)

// 2 задание -------------------------------------------------------

let generateStringList count = 
    [
        for i in 1..count do
            printfn "Введите СЛОВО для формирования списка: "
            let str = Console.ReadLine() |> string
            yield str
    ]

[<EntryPoint>]
let main args = 
    printfn "Формирование списка слов list1 с 5 словами"
    let stringList = generateStringList 5
    printfn "Исходный список: %A" stringList

    let lengthSum = List.fold (fun sum (str: string) -> sum + str.Length) 0 stringList
    printfn "Суммарная длина строк: %d" lengthSum
    0
