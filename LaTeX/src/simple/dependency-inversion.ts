// This is dependency inversion.
// The higher level component defines the interface,
// thereby allowing reuse of the high-level component.
export namespace HighLevel {

    export interface Juiceable {
        juice(): string;
    }

    export function createJuiceMedly(ingredients: Array<Juiceable>): Array<string> {
        // Dependency inversion leverages programming to interfaces.
        return ingredients.map((i) => i.juice());
    }
}

export namespace LowLevel {

    export class Orange implements HighLevel.Juiceable {
        public juice() {
            return "orange juice";
        }
    }

    export class Carrot implements HighLevel.Juiceable {
        public juice() {
            return "carrot juice";
        }
    }
}

// run
const juice = HighLevel.createJuiceMedly(
    [
        new LowLevel.Orange(),
        new LowLevel.Carrot()
    ]
);