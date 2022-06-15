/**FORMA RECURSIVA*/
object Fibonacci extends App{
   def fib(n:Int, a: Int = 0,b: Int = 1): Int={
     if(n==1)
        a
     else
        a+fib(n-1,b,a+b)
   }
  
  println(fib(10))
  def fibo(n:Long): Long={
     if(n<2) 1 else{
       var(a,b,c)=(1L,1L,1L)
       for(i<-2L until n){
         a=b
         b=c
         c=a+b
       }
       c
     }
        
   }
  
  println(fibo(1))
  
}

