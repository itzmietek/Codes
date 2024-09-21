var lowerBound = 1;
var upperBound = 100;
var targetNumber = Math.floor(Math.random() * (upperBound - lowerBound + 1)) + lowerBound;
let attempts = 0;

function guess() {
    var guessInput = document.getElementById('guess');
    var result = document.getElementById('result');
    var attemptsDisplay = document.getElementById('attempts');
    
    var userGuess = parseInt(guessInput.value, 10);
    attempts++;

    if (isNaN(userGuess) || userGuess < lowerBound || userGuess > upperBound) {
        result.textContent = `Please enter a number between ${lowerBound} and ${upperBound}.`;
    } else if (userGuess < targetNumber) {
        result.textContent = 'Too low, try again  ,  ';
    } else if (userGuess > targetNumber) {
        result.textContent = 'Too high, try again ,   ';
    } else if (UserGuess = targetNumber) {
        result.textContent = `Congratulations, you guessed the number, `;
    }
    
    attemptsDisplay.textContent = `   attempts: ${attempts}`;
}
