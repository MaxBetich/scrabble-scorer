Point Values:
[A, E, I, O, U, L, N, R, S, T ]      1
[D, G]                               2
[B, C, M, P]                         3
[F, H, V, W, Y]                      4
[K]                                  5
[J, X]                               8
[Q, Z]                               10

Given: word string, EX: "scrabble"
Expected Output: 14
[
  1: A
  1: E
  ...
  2: D
  2: G
  ...
]

-turn input string into a char array -> [s,c,r,a,b,b,l,e]
-Array.Exist()
-define a wordScore variable, start it equal to 0
-foreach char in the char array, return the point value of the letter
-sum the point values and return the final score

