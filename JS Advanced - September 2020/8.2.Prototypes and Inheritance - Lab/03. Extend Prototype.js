function extendClass(classToExtend, species = 'Human') {  
    classToExtend.prototype.species = species;
    classToExtend.prototype.toSpeciesString = function(){ return `I am a ${this.species}. ${this.toString()}`}
}