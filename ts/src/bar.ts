export interface IBar {
    doSomeThings(): number
}

export class Bar implements IBar {
    doSomeThings(): number {
        return Math.floor(Math.random() * 10)
    }
}
