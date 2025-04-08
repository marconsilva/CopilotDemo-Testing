module.exports = {
  testEnvironment: 'node',
  transform: {
    '^.+\\.jsx?$': 'babel-jest',
  },
  moduleFileExtensions: ['js', 'jsx', 'json', 'node'],
  testPathIgnorePatterns: ['/node_modules/', '/dist/'],
  coverageDirectory: 'coverage',
  collectCoverage: true,
  collectCoverageFrom: [
    'src/**/*.js',
    '!src/**/index.js',
    '!**/node_modules/**',
  ],
  testRegex: '(/__tests__/.*|(\\.|/)(test|spec))\\.jsx?$',
};