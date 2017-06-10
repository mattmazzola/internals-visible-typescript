import { IBar } from './bar'
import { InternalFoo } from './foo'

describe('Foo', () => {
    test('getTotal should return addition of two values', () => {
        // Arrange
        const mockValue = 10
        const MockBar = class MockBar implements IBar {
            doSomeThings(): number {
                return mockValue
            }
        }

        const fooValue = 10
        const foo = new InternalFoo(fooValue, new MockBar())

        // Act
        const result = foo.getTotal()

        // Assert
        expect(result).toBe(fooValue + mockValue)
    })
})