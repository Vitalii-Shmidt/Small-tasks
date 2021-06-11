 #!/bin/bash 
echo "Enter numbers:"
read x
read y

answer=$(echo $(( x + y )))
sum="$x + $y = $answer"
echo $sum
echo "$sum" >> ans.txt

answer=$(echo $((x - y)))
sub="$x - $y = $answer"
echo $sub
echo "$sub" >> ans.txt

answer=$(echo $(( x / y )))
div="$x - $y = $answer"
echo $div
echo "$div" >> ans.txt

answer=$(echo $(( x * y )))
mul="$x - $y = $answer"
echo $mul
echo "$mul" >> ans.txt

answer=$(echo $(( x % y )))
mod="$x - $y = $answer"
echo $mod
echo "$mod" >> ans.txt