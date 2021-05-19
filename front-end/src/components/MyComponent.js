import React from 'react';

class MyComponent extends React.Component {
  componentDidMount() {
    const apiUrl = 'http://localhost:5000/api/user/';
    fetch(apiUrl)
      .then((response) => response.json())
      .then((data) => console.log('This is your data', JSON.stringify(data)))
  }
  render() {
    return <h1>my Component has Mounted, Check the browser 'console' </h1>;
  }
}
export default MyComponent;