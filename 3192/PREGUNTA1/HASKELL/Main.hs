main = do
  putStrLn "Hello"
--SOLO SE PUEDE HACER DE ESTA FORMA
fib :: Integer -> Integer
fib 0 = 0
fib 1 = 1
fib n = fib (n-1) + fib (n-2)
