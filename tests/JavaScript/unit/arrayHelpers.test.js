// This file contains unit tests for the arrayHelpers module, testing its utility functions.

const { FilterUnique, SortArray } = require('../../src/JavaScript/utils/arrayHelpers');

describe('Array Helpers', () => {
    describe('FilterUnique', () => {
        it('should return an array with unique values', () => {
            const input = [1, 2, 2, 3, 4, 4, 5];
            const expectedOutput = [1, 2, 3, 4, 5];
            expect(FilterUnique(input)).toEqual(expectedOutput);
        });

        it('should return an empty array when input is empty', () => {
            const input = [];
            const expectedOutput = [];
            expect(FilterUnique(input)).toEqual(expectedOutput);
        });
    });

    describe('SortArray', () => {
        it('should return a sorted array in ascending order', () => {
            const input = [5, 3, 8, 1, 2];
            const expectedOutput = [1, 2, 3, 5, 8];
            expect(SortArray(input)).toEqual(expectedOutput);
        });

        it('should handle an already sorted array', () => {
            const input = [1, 2, 3, 4, 5];
            const expectedOutput = [1, 2, 3, 4, 5];
            expect(SortArray(input)).toEqual(expectedOutput);
        });

        it('should return an empty array when input is empty', () => {
            const input = [];
            const expectedOutput = [];
            expect(SortArray(input)).toEqual(expectedOutput);
        });
    });
});