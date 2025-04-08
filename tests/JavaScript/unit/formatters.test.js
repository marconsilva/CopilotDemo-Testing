// This file contains unit tests for the formatters module, testing its formatting functions.

const { FormatDate, FormatCurrency } = require('../../utils/formatters');

describe('Formatters', () => {
    describe('FormatDate', () => {
        it('should format date correctly', () => {
            const date = new Date('2023-10-01');
            const formattedDate = FormatDate(date);
            expect(formattedDate).toBe('October 1, 2023'); // Adjust expected format as necessary
        });

        it('should return an empty string for invalid date', () => {
            const invalidDate = new Date('invalid-date');
            const formattedDate = FormatDate(invalidDate);
            expect(formattedDate).toBe('');
        });
    });

    describe('FormatCurrency', () => {
        it('should format currency correctly', () => {
            const amount = 1234.56;
            const formattedCurrency = FormatCurrency(amount);
            expect(formattedCurrency).toBe('$1,234.56'); // Adjust expected format as necessary
        });

        it('should handle negative amounts', () => {
            const amount = -1234.56;
            const formattedCurrency = FormatCurrency(amount);
            expect(formattedCurrency).toBe('-$1,234.56'); // Adjust expected format as necessary
        });
    });
});