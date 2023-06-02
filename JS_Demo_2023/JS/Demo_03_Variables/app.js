console.log("hello from demo 03 app.js")

var myVariable = "Here's some text in a string";
myVariable = 123;
myVariable = false;
myVariable = "See how we changed it with no problems?";

let myName = "Hector";
let myAge = 44;
let myHeight = 182.19;
let isFunny = false;
isFunny = "definitely";

console.log(isFunny);

const myBirthYear = 1922;
//myBirthYear = 1987 will not work
console.log(myBirthYear);

const myBirthDate = new Date("1922-02-01");

const cardinalDirs = ["NORTH", "EAST", "SOUTH", "WEST"];

console.log(cardinalDirs);

console.log(cardinalDirs[0]);

cardinalDirs[0] = "Norte";
cardinalDirs[1] = "Este";
cardinalDirs[2] = "Sud";
cardinalDirs[3] = "Oeste";


console.log(cardinalDirs);

const looseyGooseyArray = [123, false, "Dogs", myBirthDate];

console.log(looseyGooseyArray);

//array methods: pop, push, filter, indexOf, isArray, etc.

const birdSpecies = ["Northern Cardinal", "Robin", "Blue Jay"];

birdSpecies.push("House Sparrow");//add at last element
birdSpecies.push("Song Sparrow");
birdSpecies.push("Pigeon");

console.log(birdSpecies);

birdSpecies.pop();//remove at last element
//const removedBird = birdSpecies.pop();
//const popResult = birdSpecies.pop();
//console.log("popResult: " + popResult)

console.log(birdSpecies);

const onlySparrows = birdSpecies.filter(function(bird){
    return bird.includes("Sparrow");
})

console.log(onlySparrows);

console.log(birdSpecies.indexOf("Blue Jay"));
console.log(birdSpecies.indexOf("Black Jay"));

birdSpecies.unshift("Canada Goose");//add at first element

console.log(birdSpecies);

console.log("birdSpecies array, index 20: " + birdSpecies[20]);

let myNull;
let myUndefined;

console.log("myNull: " + myNull);
console.log("myUndefined: " + myUndefined);

myNull = null;

console.log("myNull: " + myNull);

//=   assigns a value
//comparisons:
//==  loose equality
//=== strict equality
//!=  lose inequality
//!== strict inequality

const numAsString = "5";
const numAsNumber = 5;

console.log("Is the string '5' equal to the number 5 using ==?")
if(numAsString == numAsNumber){
    console.log("Yes!")
}
console.log("Is the string '5' equal to the number 5 using ===?")
if(numAsString === numAsNumber){
    console.log("Yes!")
}
else {
    console.log("No!")
}

if (myNull == myUndefined){
    console.log("myNull == myUndefined")
}
if (myNull === myUndefined){
    console.log("myNull === myUndefined: true")
}
else{
    console.log("myNull === myUndefined: false")
}

function myFunction(){
    console.log("Do a thing.")
}

myFunction();

function myFunctionWithParameters(firstParam, secondParam){
    return firstParam + ", " + secondParam;
}

const myFuncResult1 = myFunctionWithParameters("dog", "cat");
console.log(myFuncResult1);

const myFuncResult2 = myFunctionWithParameters(200, 400);
console.log(myFuncResult2);

const myFuncResult3 = myFunctionWithParameters(myBirthDate, birdSpecies);
console.log(myFuncResult3);


function myAddFunction(a, b){
    return a + b;
}
//console.log(myAddFunction(2, 5));

//arrow function: no function name
let myAddResult = (a, b) => {
    return a + b;
}
//console.log(myAddResult(2, 5));

let myAddResultArrowFunction = (a, b) => a + b;
//console.log(myAddResultArrowFunction(2, 5));

let myAddFunctionStripped = a => a + a;//can only omit parentheses if one parameter.
//console.log(myAddFunctionStripped(7));

for (let i = 0; i < birdSpecies.length; i++) {
    const bird = birdSpecies[i];

    console.log(`${i + 1}, ${bird}`);
}

for (const bird of birdSpecies) {
    console.log(bird);
}

birdSpecies.forEach(b => console.log("forEach: " + b.toUpperCase()));

birdSpecies.forEach(currentBird => {
    if(currentBird.includes("Sparrow")){
        console.log(currentBird.toUpperCase());
    }
});

