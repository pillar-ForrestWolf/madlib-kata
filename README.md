# madlib-kata
### This kata describes building a madlib style puzzle app

In this app a user should have the ability to 
* [access a puzzle library](#access-puzzle-library)
* [create new puzzle](#create-new-puzzle)
* [play existing puzzle](#play-existing-puzzle)
* [view all completed puzzles](#view-user-puzzles)
* [edit existing puzzle](edit-existing-puzzle)

### Technical Requirements


**Frontend**

Angular app created with [angular-cli](https://cli.angular.io/)
Tests should be written in [Jasmine](https://jasmine.github.io/api/3.5/global)


**Backend**

Restful service implemented in [dotnet core](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/install)
Tests should be written in [xunit](https://xunit.net/docs/getting-started/netcore/cmdline)


**Database**

[Dynamodb](https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DynamoDBLocal.DownloadingAndRunning.html)


### Access Puzzle Library

All created puzzles are displayed.
User should be able to add new puzzle to library. 
User should be able to select puzzle to play. 
User should be able to edit any puzzle. 


### Create New Puzzle

Puzzle creation form is dynamic. 
User can add plain text, or inputs with specified puzzle hints to compose puzzle.
User can rearrange plan text and input hint pieces preferable via click and drag. 
User can remove plaint text and input hint pieces. 


### Play Existing Puzzle

Puzzle is presented with input hints to be replaced by user input. 
User cannot add/remove/rearrange puzzle pieces. 
Completed puzzles are saved for future viewing. 
Bonus: use google dictionary api to validate input matches hint.


### View User Puzzles

User is able to read puzzles they have previously played. 
These puzzles are completely readonly. 


### Edit Existing Puzzle

Puzzle edit form should behave like puzzle creation. 
User can add plain text, or inputs with specified puzzle hints to compose puzzle.
User can rearrange plan text and input hint pieces preferable via click and drag. 
User can remove plaint text and input hint pieces. 
