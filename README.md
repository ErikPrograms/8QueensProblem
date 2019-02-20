# 8QueensProblem

Current tasks:
-Implement Backtracking AI
-Count amount of successes


Your current goal is to add the AI, you can do this using the GridSaver class and the IsBoardValid method in the grid class.
You place a peice at the lowest spot in a row, then move to the next collum and do the same untill board is not valid.

Example:

Step 1        Step 2      Step 3       Step 4      Step 5      Ect

| | | |       | | | |     | | | |     | | | |      | |X| |

| | | |       | | | |     | | | |      | |X| |     | | | |

| | | |       |X| | |     |X|X| |      |X| | |     |X| | |

               -Place     -Place        -Place      -Place

-Valid         -Valid     -Not Valid    -Not Valid  -Valid

-Save          -Save      -Undo         - Undo      -Save



Thsi process should continue untill you have done all solutions. You will know if you are at a soluation when a queen is in every row
and the IsBoardValid is returning true. Please keep track of any valid solutions by using the SaveValid() method in the GridSaver class.
