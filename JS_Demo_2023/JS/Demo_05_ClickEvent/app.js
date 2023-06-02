const createParagraphLink = document.getElementById("createParagraph");
const paragraphContainer = document.getElementById("contentWrapper");

console.log(createParagraphLink);



// createParagraphLink.addEventListener(  "click"  ,
//     function()
//     {
//         console.log("click detected!")
//     }
// );


createParagraphLinl.addEventListener('click', () => {
    const p = document.createElement('p');
    p.innerText = "A brand new paragraph created in javascript.";
    paragraphContainer.appendChild(p);
}
)
