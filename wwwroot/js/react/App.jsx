import PeoplesList from './PeoplesList';



class App extends React.Component {
    render() {
        return (
            <div className="App">
                <h1> Peoples </h1>
                <PeoplesList/>
            </div>
        );
    }
}

ReactDOM.render(<App />, document.getElementById('content'))
