import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Iterator;

public class Notebooks implements Iterable<Notebook> {
    private ArrayList<Notebook> notebookList;

    public Notebooks() {
        notebookList = new ArrayList<>();
    }

    public void clear() {
        notebookList.removeAll(notebookList);
    }

    public String[] toStringArray() {
        String[] output = new String[notebookList.size()];
        int i = 0;
        for (Notebook notebook : notebookList) {
            output[i++] = notebook.toString();
        }
        return output;
    }

    public Notebook getFromList(int index) {
        return notebookList.get(index - 1);
    }

    public void addPosition(Notebook notebook) {
        if (!notebookList.contains(notebook)) {
            notebookList.add(notebook);
        } else
            System.out.println(Messages.addingError);
    }

    public void deletePosition(Notebook notebook) {
        if (notebookList.contains(notebook)) {
            notebookList.remove(notebook);
        } else
            System.out.println(Messages.existError);
    }

    public void getPositionsFromSet(HashSet<HashMap<String, String>> parametersSet) {
        for (HashMap<String, String> parameters : parametersSet) {
            Notebook notebook = new Notebook(parameters);
            if (!notebookList.contains(notebook)) {
                notebookList.add(notebook);
            } else
                System.out.println(Messages.addingError);
        }
    }

    public void requestPositions(HashMap<String, String> requirements) {
        ArrayList<Notebook> temp = new ArrayList<>();
        for (Notebook notebook : notebookList) {
            if (notebook.isSatisfied(requirements)) {
                temp.add(notebook);
            }
        }
        notebookList = temp;
    }

    public String[] getKeys(String key) {
        String[] output = new String[notebookList.size()];
        int i = 0;
        for (Notebook notebook : notebookList) {
            output[i++] = (notebook.getParameters().get(key));
        }
        return output;
    }

    @Override
    public String toString() {
        String output = new String();
        for (Notebook notebook : notebookList) {
            output += notebook.toString() + "\n";
        }
        return output;
    }

    @Override
    public Iterator<Notebook> iterator() {
        Iterator<Notebook> iterator = new Iterator<Notebook>() {

            private int currentIndex = 0;

            @Override
            public boolean hasNext() {
                return currentIndex < notebookList.size() && notebookList.get(currentIndex) != null;
            }

            @Override
            public Notebook next() {
                return notebookList.get(currentIndex++);
            }

            @Override
            public void remove() {
                notebookList.remove(currentIndex);
            }
        };
        return iterator;
    }

}