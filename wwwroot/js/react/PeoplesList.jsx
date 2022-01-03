class PeoplesList extends React.Component {

    constructor() {
        super()
        this.state = {
            peoples: [],
            errorMessage: ''
        }
    }

    componentDidMount() {
        fetch('https://localhost:5001/api/React/get-all')
            .then(async response => {
                const data = await response.json();

                this.setState({ peoples: data.total })
            })
            .catch(error => {
                this.setState({ errorMessage: error.toString() });
                console.error('There was an error!', error);
            });
    }

    render() {
        return (
            <div>

            </div>
        )
    }
}

export default PeoplesList