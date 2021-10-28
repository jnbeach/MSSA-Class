var url = "https://pokeapi.co/api/v2/pokemon/";
var whichPokemon;
let searchFlag = false;
var nameDiv = document.getElementById('nameDiv');
var spriteDiv = document.getElementById('spriteDiv');
var movesList = document.getElementById('movesList');

function searchPokemon() {
    // Resets nameDiv, spriteDiv, movesDiv if a pokemon was previously searched.
    if (searchFlag == true) {
        nameDiv.innerHTML = '<h2>Pokemon Name:</h2>';
        spriteDiv.innerHTML = '<h2>Sprites:</h2>';
        movesList.innerHTML = ""
    }

    whichPokemon = document.getElementById("searchbar").value;
    whichPokemon = whichPokemon.toLowerCase();
    url = "https://pokeapi.co/api/v2/pokemon/"
    url += whichPokemon; // url = url + pokemon
    fetch(url)
        .then(response => response.json())
        .then(pokemon => {

            capitalPokeName = capitalize(pokemon.name);
            nameDiv.innerHTML += '<p>' + capitalPokeName + '</p>';
            nameDiv.innerHTML += "<img src=" + pokemon.sprites.other["official-artwork"].front_default + ">";
            spriteDiv.innerHTML += "<div class='spriteImgDiv'><img src=" + pokemon.sprites.back_default + "></div>";
            spriteDiv.innerHTML += "<div class='spriteImgDiv'><img src=" + pokemon.sprites.front_default + "></div>";


            for (let i = 0; i < 4; i++) {

                let numberOfMoves = pokemon.moves.length
                let moveIndex = Math.floor(Math.random() * numberOfMoves);
                var moveName = pokemon.moves[moveIndex].move.name
                movesList.innerHTML += '<li>' + capitalize(moveName) + '</li>';
            }


            console.log(pokemon);
        }).catch(err => console.log(err))
    if (searchFlag == false) {
        searchFlag = true;
    }
}

//Capitalizes the first letter of any string.
function capitalize(string) {
    let lowerString1 = string.slice(0, 1);
    let lowerString2 = string.slice(1);
    let upperString1 = lowerString1.toUpperCase();
    return upperString1 + lowerString2;

}