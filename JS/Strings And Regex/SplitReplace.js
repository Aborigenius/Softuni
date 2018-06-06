function splitReplace(targetWord, text) {
    //replace works only ofr the first match
    //replace with regex /g - global replaces all
    let counter = 0;
    let index = text.indexOf(targetWord);

    while (index > -1) {
        counter++;
        index = text.indexOf(targetWord, index + 1);
    }
    console.log(counter);
}

splitReplace('the', 'The quick brown fox jumps over the lay dog.');
splitReplace('ma', 'Marine mammal training is the training and caring for marine life such as, dolphins, killer whales, sea lions, walruses, and other marine mammals. It is also a duty of the trainer to do mental and physical exercises to keep the animal healthy and happy.');