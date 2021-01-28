function solve() {

    class Figure {
        constructor(units = 'cm') {
            this.units = units;
        }

        changeUnits(newUnits) {
            this.units = newUnits;
        }

        transformMetric(valInCm) {
            return this.units === 'm' ?
                valInCm / 100 : this.units === 'mm' ?
                    valInCm * 10 : valInCm;
        }

        get area() { throw new Error('Not Implemented!') }

        toString() {
            return `Figures units: ${this.units} Area: ${this.area}`;
        }
    }

    class Circle extends Figure {
        constructor(radius, units) {
            super(units)

            this.radius = radius;
        }

        get area() {
            const radius = this.transformMetric(this.radius);
            return Math.PI * radius * radius;
        }

        toString() {
            const r = this.transformMetric(this.radius);
            return `${super.toString()} - radius: ${r}`;
        }
    }

    class Rectangle extends Figure {
        constructor(width, height, units) {
            super(units);
            this.width = width;
            this.height = height;
        }

        get area() {
            const width = this.transformMetric(this.width);
            const height = this.transformMetric(this.height);

            return height * width;
        }

        toString() {
            const width = this.transformMetric(this.width);
            const height = this.transformMetric(this.height);
            return `${super.toString()} - width: ${width}, height: ${height}`;            
        }
    }   
    
    return{
        Figure,
        Circle,
        Rectangle
    }
}
