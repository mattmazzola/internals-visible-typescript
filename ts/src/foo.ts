import { IBar, Bar } from './bar'

export class Foo {
    private value: number
    protected bar: IBar

    constructor (value: number) {
        this.value = value
        this.bar = new Bar()
    }

    getTotal() {
        return this.value + this.bar.doSomeThings()
    }
}

export class InternalFoo extends Foo {
    constructor (value: number, bar: IBar) {
        super(value)
        this.bar = bar
    }
}